using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopOlustur : MonoBehaviour
{
    float time;
    
    public GameObject firsPosition;
    public GameObject pinponPrefab, bilardoPrefab, tenisPrefab, golfPrefab, beyzbolPrefab;
    public GameObject ilkTopPrefab;

    public static bool prefabOlustur = true;

    int baraj = 0;

    private void Start()
    {                
        Instantiate(ilkTopPrefab, firsPosition.transform.position, Quaternion.identity);
    }
    void Update()
    {
        CollisionScript.once = 1;

        if (TopHareket.parmak.phase == TouchPhase.Ended)
        {
            if (prefabOlustur)
            {
                time += Time.deltaTime;


                if (time > 1.5f)
                {
                    int randomNumber = Random.Range(1, 6);

                    if (baraj < 5)
                    {
                        Instantiate(pinponPrefab, firsPosition.transform.position, Quaternion.identity);
                        baraj++;
                        time = 0f;
                    }

                    else if (baraj >= 5 && baraj < 25)
                    {
                        int randomNumber1 = Random.Range(1, 3);

                        if (randomNumber1 == 1)
                        {
                            Instantiate(pinponPrefab, firsPosition.transform.position, Quaternion.identity);
                            baraj++;
                            time = 0f;
                        }
                        else if (randomNumber1 == 2)
                        {
                            Instantiate(bilardoPrefab, firsPosition.transform.position, Quaternion.identity);
                            baraj += 2;
                            time = 0f;
                        }
                    }

                    else if (baraj >= 25 && baraj < 55)
                    {
                        int randomNumber2 = Random.Range(1, 4);

                        if (randomNumber2 ==1)
                        {
                            Instantiate(pinponPrefab, firsPosition.transform.position, Quaternion.identity);
                            baraj++;
                            time = 0f;
                        }
                        else if (randomNumber2 == 2)
                        {
                            Instantiate(bilardoPrefab, firsPosition.transform.position, Quaternion.identity);
                            baraj += 2;
                            time = 0f;
                        }
                        else if (randomNumber2 == 3)
                        {
                            Instantiate(tenisPrefab, firsPosition.transform.position, Quaternion.identity);
                            baraj += 3;
                            time = 0f;
                        }
                    }

                    else if (baraj >= 55 && baraj < 90)
                    {
                        int randomNumber2 = Random.Range(1, 5);

                        if (randomNumber2 == 1)
                        {
                            Instantiate(pinponPrefab, firsPosition.transform.position, Quaternion.identity);
                            baraj++;
                            time = 0f;
                        }
                        else if (randomNumber2 == 2)
                        {
                            Instantiate(bilardoPrefab, firsPosition.transform.position, Quaternion.identity);
                            baraj += 2;
                            time = 0f;
                        }
                        else if (randomNumber2 == 3)
                        {
                            Instantiate(tenisPrefab, firsPosition.transform.position, Quaternion.identity);
                            baraj += 3;
                            time = 0f;
                        }
                        else if (randomNumber2 == 4)
                        {
                            Instantiate(golfPrefab, firsPosition.transform.position, Quaternion.identity);
                            baraj += 4;
                            time = 0f;
                        }
                    }

                    else if (baraj >= 90)
                    {
                        int randomNumber2 = Random.Range(1, 6);

                        if (randomNumber2 == 1)
                        {
                            Instantiate(pinponPrefab, firsPosition.transform.position, Quaternion.identity);
                            baraj++;
                            time = 0f;
                        }
                        else if (randomNumber2 == 2)
                        {
                            Instantiate(bilardoPrefab, firsPosition.transform.position, Quaternion.identity);
                            baraj += 2;
                            time = 0f;
                        }
                        else if (randomNumber2 == 3)
                        {
                            Instantiate(tenisPrefab, firsPosition.transform.position, Quaternion.identity);
                            baraj += 3;
                            time = 0f;
                        }
                        else if (randomNumber2 == 4)
                        {
                            Instantiate(golfPrefab, firsPosition.transform.position, Quaternion.identity);
                            baraj += 4;
                            time = 0f;
                        }
                        else if (randomNumber2 == 5)
                        {
                            Instantiate(beyzbolPrefab, firsPosition.transform.position, Quaternion.identity);
                            baraj += 5;
                            time = 0f;
                        }
                    }

                    prefabOlustur = false;
                }
            }

        }
    }
}
