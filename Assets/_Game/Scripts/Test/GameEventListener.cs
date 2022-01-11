using UnityEngine;
using UnityEngine.Events;

namespace Test
{
    public class GameEventListener : MonoBehaviour
    {
        [SerializeField] GameEvent _gameEvent;
        [SerializeField] UnityEvent _unityEvent;

        private void Awake() => _gameEvent.Register(gameEventListener: this);

        private void OnDestroy() => _gameEvent.Deregister(gameEventListener: this);

        public void RaiseEvent() => _unityEvent.Invoke();
    }
}
