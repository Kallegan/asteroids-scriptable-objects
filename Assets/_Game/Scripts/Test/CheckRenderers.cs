using UnityEngine;

namespace Test
{
    
    public class CheckRenderers : MonoBehaviour
    {
        [SerializeField] GameEvent _screenWrapEvent;
        
        private bool outOfBounds;
        
        void OnBecameVisible()
        {
            outOfBounds = false;
            Debug.Log("visable");
        }

        void OnBecameInvisible()
        {
            if (outOfBounds == false)
            {
                _screenWrapEvent?.Invoke();
                Debug.Log("not visable");
                outOfBounds = true;
            }
          
        }
    }
}

