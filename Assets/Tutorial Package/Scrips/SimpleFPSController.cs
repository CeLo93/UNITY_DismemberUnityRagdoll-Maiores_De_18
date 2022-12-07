using UnityEngine;

public class SimpleFPSController : MonoBehaviour
{
    Transform myTransform;

    [SerializeField] Transform mainCamera;
    [SerializeField] float moveSpeed = 15, strafeSpeed = 5, turnSpeed = 180, lookSpeed = 75;

    float mouseRotationX = 0f;

    // Start is called before the first frame update
    void Start()
    {
        myTransform = transform;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            myTransform.Translate(Vector3.right * Input.GetAxis("Horizontal") * strafeSpeed * Time.deltaTime);
        }

        if (Input.GetAxis("Vertical") != 0)
        {
            myTransform.Translate(Vector3.forward * Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime);
        }

        if (Input.GetAxis("Mouse X") != 0)
        {
            myTransform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * turnSpeed * Time.deltaTime);
        }

        if (Input.GetAxis("Mouse Y") != 0)
        {
            mouseRotationX += Input.GetAxis("Mouse Y") * lookSpeed * Time.deltaTime;

            mouseRotationX = Mathf.Clamp(mouseRotationX, -60F, 60F);

            mainCamera.localEulerAngles = new Vector3(-mouseRotationX, 0, 0);
        }

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            if (Physics.Raycast(mainCamera.position, mainCamera.forward, out hit, Mathf.Infinity))// Colocar a condição do tiro hit
            {
                if (hit.transform.GetComponent<Limb>())
                {
                    Limb limb = hit.transform.GetComponent<Limb>();
                    limb.Gethit();
                }
            }
        }

        Debug.DrawRay(mainCamera.position, mainCamera.forward);
    }
}
