using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VRInteract : MonoBehaviour{
	public GameObject PlayerRig;
	public Image imgGaze; //untuk menyimpan gambar loading pada cursor ketika gaze
	public float totalTime = 2; //waktu yg diperlukan utk full loading gaze
	//bool gvrStatus; //boolean utk cek apakah sedang hover cursor atau tidak
	float gvrTimer=0; //inisialisasi counter waktu
	
	public int distanceOfRay = 20; //jarak raycast, atau titik cursor dari camera ke objek
	private RaycastHit _hit; //untuk menerima objek apa yang terkena raycast
		
    void Start(){
        Screen.sleepTimeout = SleepTimeout.NeverSleep; //agar layar HP tidak sleep
    }

    void Update(){
		Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f)); //mengeluarkan raycast dari titik tengah camera
		
		//dibawah ini adalah fungsi untuk gaze input & teleport		
        if(Physics.Raycast(ray, out _hit, distanceOfRay)){ //mengecek apakah cursor sedang hover
			gvrTimer += Time.deltaTime; //counter waktu secara real
			imgGaze.fillAmount = gvrTimer/totalTime; //mengisi & animasi fill pada gambar imggaze
		} else
		{
			gvrTimer = 0;
			imgGaze.fillAmount = 0;
		}
				
		//Gaze Input		
		if(Physics.Raycast(ray, out _hit, distanceOfRay)){ //apabila raycast mengenai sesuatu
			if(imgGaze.fillAmount == 1 && _hit.collider.CompareTag("GantiScene")){ //apabila loading gaze sudah selesai dan objek sesuatu itu adalah tag teleport				
				//_hit.transform.gameObject.GetComponent<Teleport>().TeleportPlayer(); //jalankan fungsi TeleportPlayer yang terdapat pada objek tersebut
				Debug.Log("Ganti Scene" + _hit.collider.gameObject.name);
                SceneManager.LoadSceneAsync(_hit.collider.gameObject.name);
				gvrTimer=0;
				imgGaze.fillAmount = 0;
			}
			if(imgGaze.fillAmount == 1 && _hit.collider.CompareTag("VRbutton")){
				Destroy(PlayerRig);
				SceneManager.LoadScene("SplashScreen");
				gvrTimer=0;
				imgGaze.fillAmount = 0;
			}
			if(imgGaze.fillAmount == 1 && _hit.collider.CompareTag("info")){
				SceneManager.LoadScene("info_VR");
				gvrTimer=0;
				imgGaze.fillAmount = 0;
			}
			if(imgGaze.fillAmount == 1 && _hit.collider.CompareTag("exit")){
				Application.Quit();
			}
			if(imgGaze.fillAmount == 1 && _hit.collider.CompareTag("Home")){
				SceneManager.LoadScene("vr_2");
				gvrTimer=0;
				imgGaze.fillAmount = 0;
			}
		}
			
    }
	
	
}
