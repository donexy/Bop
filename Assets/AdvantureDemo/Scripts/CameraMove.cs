using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

public class CameraMove : MonoBehaviour
{
    [Header("Zoom")]
    [SerializeField] Transform player;
    [SerializeField] float zoomStartTime;
    [SerializeField] float zoomSize;
    [SerializeField] float zoomSpeed;

    [Header("Final Scene")]
    [SerializeField] Image finalSceneImage;
    [SerializeField] float finalSceneTime;
    [SerializeField] float finalSceneSpeed;

    float _counter = 0;
    bool _isBool = false;
    bool _isFinalScene = false;
    void Start()
    {
        Camera.main.orthographicSize = 12;

        if(_isFinalScene == false)
        {
            Color objcolor = finalSceneImage.color;
            objcolor.a = 0f;
            finalSceneImage.color = objcolor;
        }
        
    }

    void Update()
    {
        _counter += Time.deltaTime;

        if(_counter >= zoomStartTime) _isBool = true;


        if (_isBool == true)
        {
            Camera.main.orthographicSize = Mathf.MoveTowards(Camera.main.orthographicSize, zoomSize, zoomSpeed * Time.deltaTime);
            transform.position = new Vector3(player.position.x, player.position.y + 1.2f, -10f);

        }

        if (_counter >= finalSceneTime) _isFinalScene = true;

        if (_isFinalScene == true)
        {
            Color renk = finalSceneImage.color;
            renk.a = Mathf.MoveTowards(renk.a, 1f, finalSceneSpeed * Time.deltaTime);
            finalSceneImage.color = renk;
        }
    }

    

}
