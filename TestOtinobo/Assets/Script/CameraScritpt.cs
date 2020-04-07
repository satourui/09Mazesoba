using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraScritpt : MonoBehaviour
{
    [SerializeField] GameObject Player;
    //このスクリプトは ごり押し適当仕様 なので後々作り直します
    void Start()
    {

    }

    void Update()
    {
        transform.position = new Vector3(0, Player.transform.position.y + 4, -10);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

    }
}
