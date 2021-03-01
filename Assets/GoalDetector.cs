// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class GoalDetector : MonoBehaviour
// {

//      public GameObject scoreBlue;
//      public GameObject scoreOrange;
//      private int scoreb = 0;
//      private int scoreo = 0;

//     void Start()
//     {   
//         scoreBlue.SetActive(false);
//         scoreOrange.SetActive(false);
//     }

//      private void OnTriggerEnter2D(Collider2D other) {

//         if (other.gameObject.CompareTag("Orange")) {
//             var G2 = GameObject.Find("girl 2").transform.position.x;
//             if(scoreb == 0) {
//                 scoreBlue.SetActive(true);
//                 scoreb = scoreb +1;
//             } else{
//                 GameObject go = GameObject.Instantiate(scoreBlue);
//                 go.transform.SetParent(GameObject.Find("girl 2").transform);
//                 go.transform.position = new Vector3(G2 + 0.1f, GameObject.Find("girl 2").transform.position.y - 0.1f, 0);
//                 scoreb = scoreb +1;
//             }


//         }
//         if (other.gameObject.CompareTag("Blue")) {
//             var G1 = GameObject.Find("girl 1").transform.position.x;
//             if(scoreo == 0){
//                 scoreOrange.SetActive(true);
//                  scoreo = scoreo +1;
//             }else{
//                 GameObject go = GameObject.Instantiate(scoreOrange);
//                 go.transform.SetParent(GameObject.Find("girl 1").transform);
//                 go.transform.position = new Vector3(G1 + 0.1f, GameObject.Find("girl 1").transform.position.y - 0.1f, 0);
//                  scoreo = scoreo +1;
//             }

//         }
//     }
// }