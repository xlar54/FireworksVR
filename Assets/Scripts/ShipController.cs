using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour {

    public float speed = 0.5f;

    [Space(20)]
    #region movement
    public float offset_lerp = 5;

    public Vector3 move_wave_amp = new Vector3(0.1f, 0.1f, 0.1f);
    public Vector3 move_speed = new Vector3(5f, 5f, 5f);
    public Vector3 move_clamp = new Vector3(0.5f, 0.5f, 0.5f);
    #endregion

    [Space(20)]
    #region rotation
    public float rotate_lerp = 5;

    public Vector3 rotate_wave_amp = new Vector3(10f, 10f, 10f);
    public Vector3 rotate_speed = new Vector3(5f, 5f, 5f);
    #endregion

    // Use this for initialization
    void Start () {
		
	}

    private void Update()
    {
        Vector3 dir = Vector3.forward * Time.deltaTime * speed;
        transform.Translate(dir);

        //rotation
        float rotx = rotate_wave_amp.x * Mathf.Sin((Mathf.PerlinNoise(Time.time, 4) * rotate_speed.x));
        float roty = rotate_wave_amp.y * Mathf.Sin((Mathf.PerlinNoise(Time.time, 5) * rotate_speed.y));
        float rotz = rotate_wave_amp.z * Mathf.Sin((Mathf.PerlinNoise(Time.time, 6) * rotate_speed.z));

        Quaternion rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(rotx, roty, rotz), Time.deltaTime * rotate_lerp);
        transform.rotation = rotation;

    }

    // Update is called once per frame
    void boatRocking() {

        //transform.Rotate(new Vector3(Mathf.PingPong((Time.time * speed), 0.0625f) - 0.03125f, 0, 0));

        
        //movement
        float offx = move_wave_amp.x * Mathf.Sin((Mathf.PerlinNoise(Time.time, 1) * move_speed.x));
        float offy = move_wave_amp.y * Mathf.Sin((Mathf.PerlinNoise(Time.time, 2) * move_speed.y));
        float offz = move_wave_amp.z * Mathf.Sin((Mathf.PerlinNoise(Time.time, 3) * move_speed.z));

        Vector3 movement = Vector3.Lerp(transform.position, new Vector3(offx, offy, offz), Time.deltaTime * offset_lerp);
        movement.x = Mathf.Clamp(movement.x, -move_clamp.x, move_clamp.x);
        movement.y = Mathf.Clamp(movement.y, -move_clamp.y, move_clamp.y);
        movement.z = Mathf.Clamp(movement.z, -move_clamp.z, move_clamp.z);
        transform.position = movement;

        //rotation
        float rotx = rotate_wave_amp.x * Mathf.Sin((Mathf.PerlinNoise(Time.time, 4) * rotate_speed.x));
        float roty = rotate_wave_amp.y * Mathf.Sin((Mathf.PerlinNoise(Time.time, 5) * rotate_speed.y));
        float rotz = rotate_wave_amp.z * Mathf.Sin((Mathf.PerlinNoise(Time.time, 6) * rotate_speed.z));

        Quaternion rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(rotx, roty, rotz), Time.deltaTime * rotate_lerp);
        transform.rotation = rotation;

    }
}
