
using System;
using Test;
using UnityEngine;


namespace test
{
    public class ScreenWrap : MonoBehaviour
    {
        [SerializeField] GameEvent _screenWrapEvent;
        private bool outOfBound;

        private float _minX;
        private float _minY;
        private float _maxX;
        private float _maxY;

        private Vector2 _screenBounds;
        private void Start() 
        {
            _screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height,
                    Camera.main.transform.position.z));
            _minX = _screenBounds.x;
            _minY = _screenBounds.y;
            _maxX = (_screenBounds.x * -1);
            _maxY = (_screenBounds.y * -1);
        }
        public void ScreenWrapEvent()
        {
            outOfBound = true;
            if (outOfBound) //added body check to prevent triggers searching when dead.
            {
                //check for each direction if player is crossing the 2dcollider trigger, and if so sets x/y
                //to opposite direction using the min/max values from bounds and applying to head node so others can follow.
                if (_maxX < transform.position.x && _minY < transform.position.y)
                {
                    transform.position = new Vector3(_minX, transform.position.y, 0.0f);
                }

                if (_minX > transform.position.x && _minY < transform.position.y)
                {
                    transform.position = new Vector3(_maxX, transform.position.y, 0.0f);
                }

                if (_minX < transform.position.x && _minY > transform.position.y)
                {
                    transform.position = new Vector3(transform.position.x, _maxY, 0.0f);
                }

                if (_maxX > transform.position.x && _maxY < transform.position.y)
                {
                    transform.position = new Vector3(transform.position.x, _minY, 0.0f);
                }

                outOfBound = false;
            }
        }
    }
}
