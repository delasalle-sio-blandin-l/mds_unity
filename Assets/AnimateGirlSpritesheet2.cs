using UnityEngine;

[RequireComponent(typeof(SpritesheetAnimator))]
public class AnimateGirlSpritesheet2 : MonoBehaviour {
    SpritesheetAnimator animator;

    public float speed = 1.5f;

    void Start() {
        animator = GetComponent<SpritesheetAnimator>();
    }


    void Update() {
        if (Input.GetKey(KeyCode.D)) {

            transform.localRotation = Quaternion.Euler(0, 0, 0);
            animator.Play(Anims.Run);

        } else if (Input.GetKey(KeyCode.S)) {

            animator.Play(Anims.Roll);

        } else if(Input.GetKey(KeyCode.Q)) {

            transform.localRotation = Quaternion.Euler(0, 180, 0);
            animator.Play(Anims.Run);

        } else if(Input.GetKey(KeyCode.Z)) {

            animator.Play(Anims.Jump);
        } else {

            animator.Play(Anims.Iddle);
        }
    }
}