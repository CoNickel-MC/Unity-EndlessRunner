using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	public new Rigidbody rigidbody;
	public InputAction Movement;
	public InputAction Jump;
	private bool jumpFlag;

	[SerializeField] private int jumpForce;



	private void OnEnable() {
		Movement.Enable();
		Jump.Enable();
	}

	private void OnDisable() {
		Movement.Disable();
		Jump.Disable();
	}


	// Start is called before the first frame update
	void Start() {
        GameObject.FindGameObjectWithTag("Spawner").GetComponent<spawnScript>().SpawnRandom();
    }

    // Update is called once per frame
    void FixedUpdate() {
		rigidbody.velocity = new Vector3 (5 * Movement.ReadValue<float>(), rigidbody.velocity.y, 0);

        if (Jump.ReadValue<float>() == 1 && !jumpFlag) {
            rigidbody.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);

            //rigidbody.velocity = new Vector3(0, 50, 0);
            jumpFlag = true;
        }

    }

    private void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "Ground") {
			jumpFlag = false;
		}
    }
}
