using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    [Header("Spawner Cube Object")]
    public GameObject spawnCube;
    [Header("Default Difficulty")]
    public float difficulty = 40f;
    float spawn;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        spawn = difficulty * Time.deltaTime;
        difficulty = Time.deltaTime * 4f;
        while (spawn > 0)
        {
            spawn -= 1f;
            Vector3 v3Pos = transform.position + new Vector3(Random.value * 40f - 20f, 0, Random.value * 40f - 20f);
            Quaternion qRotation = Quaternion.Euler(0, Random.value * 360, Random.value * 30f);
            GameObject creatObject = Instantiate(spawnCube, v3Pos, qRotation);


        }

    }
}
