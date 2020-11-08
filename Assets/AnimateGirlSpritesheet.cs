using UnityEngine;

[RequireComponent(typeof(SpritesheetAnimator))]
public class AnimateGirlSpritesheet : MonoBehaviour {
    SpritesheetAnimator animator;

    public float speed = 1.5f;

    void Start() {
        animator = GetComponent<SpritesheetAnimator>();
    }


    void Update() {
        if (Input.GetKey(KeyCode.RightArrow)) {

            transform.localRotation = Quaternion.Euler(0, 0, 0);
            animator.Play(Anims.Run);

        } else if (Input.GetKey(KeyCode.DownArrow)) {

            animator.Play(Anims.Roll);

        } else if(Input.GetKey(KeyCode.LeftArrow)) {

            transform.localRotation = Quaternion.Euler(0, 180, 0);
            animator.Play(Anims.Run);

        } else if(Input.GetKey(KeyCode.UpArrow)) {

            animator.Play(Anims.Jump);
        } else {

            animator.Play(Anims.Iddle);
        }
    }
}