using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassSpawner : MonoBehaviour
{
    public GameObject backgroundPrefab; // Префаб фона
    public float spawnDistance = 10f; // Расстояние, на котором будет спавниться новый фон

    private Camera mainCamera;
    private GameObject currentBackground;
    private Vector3 previousCamPos;
    private Vector3 cameraPosition;
    private Vector3 position;
    private Vector3 positionX;

    void Start()
    {
        mainCamera = Camera.main;
        cameraPosition = mainCamera.transform.position;
        previousCamPos = cameraPosition;
        SpawnBackground();
    }

    void Update()
    {
        cameraPosition = mainCamera.transform.position;


        Debug.Log(" XXX " + (cameraPosition.x - previousCamPos.x));
        // Debug.Log(" YYY " + (cameraPosition.y-previousCamPos.y));

      /*if((cameraPosition.y-previousCamPos.y)>11)
      {
          position = new Vector3(mainCamera.transform.position.x, mainCamera.transform.position.y+15, 0);
          Instantiate(backgroundPrefab, position, Quaternion.identity);
          previousCamPos = new Vector3(previousCamPos.x, mainCamera.transform.position.y);
      }

        if (cameraPosition.x - previousCamPos.x > 5)
        {
            positionX = new Vector3(cameraPosition.x + 15, cameraPosition.y, cameraPosition.z);
            Instantiate(backgroundPrefab, positionX, Quaternion.identity);
            previousCamPos = new Vector3(cameraPosition.x, previousCamPos.y);
        }

        if (cameraPosition.x - previousCamPos.x < -5)
        {
            positionX = new Vector3(cameraPosition.x - 15, cameraPosition.y, cameraPosition.z);
            Instantiate(backgroundPrefab, positionX, Quaternion.identity);
            previousCamPos = new Vector3(cameraPosition.x, previousCamPos.y);
        }*/

        /*if (currentBackground == null) return;

        Vector3 cameraPosition = mainCamera.transform.position;
        Vector3 backgroundPosition = currentBackground.transform.position;

        // Проверяем, нужно ли спавнить новый фон
        if (cameraPosition.x > backgroundPosition.x + spawnDistance)
        {
            Debug.Log();
            SpawnBackground(new Vector3(backgroundPosition.x + backgroundPrefab.GetComponent<SpriteRenderer>().bounds.size.x, backgroundPosition.y, backgroundPosition.z));
        }
        else if (cameraPosition.y > backgroundPosition.y + spawnDistance)
        {
            SpawnBackground(new Vector3(backgroundPosition.x, backgroundPosition.y + backgroundPrefab.GetComponent<SpriteRenderer>().bounds.size.y, backgroundPosition.z));
        }*/
    }

    void SpawnBackground(Vector3 position = default)
    {
        if (position == default)
        {
            position = new Vector3(mainCamera.transform.position.x, mainCamera.transform.position.y, 0);
        }

        currentBackground = Instantiate(backgroundPrefab, position, Quaternion.identity);
    }


    /*
    public GameObject grassPrefab; // Префаб травы
    public float spawnDistance = 100f; // Расстояние, на котором будет спавниться трава
    public float grassDensity = 10000f; // Плотность травы (чем меньше, тем плотнее)
    public float grassAreaWidth = 20f; // Ширина области спавна травы
    public float grassAreaHeight = 20f; // Высота области спавна травы

    private Transform cam;
    private Vector3 previousCamPos;

    void Start()
    {
        cam = Camera.main.transform;
        previousCamPos = cam.position;
    }

    void Update()
    {
        Vector3 camPos = cam.position;
        Vector3 camForward = cam.forward;
        Vector3 camRight = cam.right;

        // Проверяем, двигается ли камера
        if (Vector3.Distance(previousCamPos, camPos) > grassDensity)
        {
            Debug.Log("Spawn");

            // Спавним траву впереди камеры
            SpawnGrass(camPos + camForward * spawnDistance);

            // Спавним траву по бокам камеры
            SpawnGrass(camPos + camRight * spawnDistance);
            SpawnGrass(camPos - camRight * spawnDistance);

            // Спавним траву сзади камеры (если нужно)
            SpawnGrass(camPos - camForward * spawnDistance);

            previousCamPos = camPos;
        }
    }

    void SpawnGrass(Vector3 spawnPos)
    {
        for (float x = -grassAreaWidth / 2; x < grassAreaWidth / 2; x += grassDensity)
        {
            for (float y = -grassAreaHeight / 2; y < grassAreaHeight / 2; y += grassDensity)
            {
                Vector3 grassPos = spawnPos + new Vector3(x, y, 0);
                Instantiate(grassPrefab, grassPos, Quaternion.identity);
            }
        }
    }*/
}