using UnityEngine;

namespace Test
{
    public class CheckRenderers : MonoBehaviour
    {
        
        void OnBecameVisible()
        {
            Debug.Log("visable");
            
        }

        void OnBecameInvisible()
        {
           
                //todo trigger event that will take flip x/y pos for wrap. We need the player pos and camera pos.
                
                Debug.Log("not visable");
            
        }
    }
}

