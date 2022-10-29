using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class InputController : MonoBehaviour
{
    [SerializeField] GameObject _effect;
    [SerializeField] Transform _muzzle;
    GameManager _gameManager;
    void Start()
    {
        _gameManager = GameObject.FindObjectOfType<GameManager>();
    }

    void Update()
    {
        if (_gameManager.IsGame)
        {
            Vector2 _effectPosition = new Vector2(Random.Range(_muzzle.position.x - 5, _muzzle.position.x + 5),Random.Range(_muzzle.position.y - 1, _muzzle.position.y + 1));
            if (Input.GetButtonDown("a"))
            {
                Instantiate(_effect, _effectPosition, transform.rotation);
                _gameManager.HP -= 1;
                Debug.Log("a");
            }
            if (Input.GetButtonDown("b"))
            {
                Instantiate(_effect, _effectPosition, transform.rotation);
                _gameManager.HP -= 1;
                Debug.Log("b");
            }
            if (Input.GetButtonDown("c"))
            {
                Instantiate(_effect, _effectPosition, transform.rotation);
                _gameManager.HP -= 1;
                Debug.Log("c");
            }
            if (Input.GetButtonDown("d"))
            {
                Instantiate(_effect, _effectPosition, transform.rotation);
                _gameManager.HP -= 1;
                Debug.Log("d");
            }
            if (Input.GetButtonDown("e"))
            {
                Instantiate(_effect, _effectPosition, transform.rotation);
                _gameManager.HP -= 1;
                Debug.Log("e");
            }
            if (Input.GetButtonDown("f"))
            {
                Instantiate(_effect, _effectPosition, transform.rotation);
                _gameManager.HP -= 1;
                Debug.Log("f");
            }
            if (Input.GetButtonDown("g"))
            {
                Instantiate(_effect, _effectPosition, transform.rotation);
                _gameManager.HP -= 1;
                Debug.Log("g");
            }
            if (Input.GetButtonDown("h"))
            {
                Instantiate(_effect, _effectPosition, transform.rotation);
                _gameManager.HP -= 1;
                Debug.Log("h");
            }
            if (Input.GetButtonDown("i"))
            {
                Instantiate(_effect, _effectPosition, transform.rotation);
                _gameManager.HP -= 1;
                Debug.Log("i");
            }
            if (Input.GetButtonDown("j"))
            {
                Instantiate(_effect, _effectPosition, transform.rotation);
                _gameManager.HP -= 1;
                Debug.Log("j");
            }
            if (Input.GetButtonDown("k"))
            {
                Instantiate(_effect, _effectPosition, transform.rotation);
                _gameManager.HP -= 1;
                Debug.Log("k");
            }
            if (Input.GetButtonDown("l"))
            {
                Instantiate(_effect, _effectPosition, transform.rotation);
                _gameManager.HP -= 1;
                Debug.Log("l");
            }
            if (Input.GetButtonDown("m"))
            {
                Instantiate(_effect, _effectPosition, transform.rotation);
                _gameManager.HP -= 1;
                Debug.Log("m");
            }
            if (Input.GetButtonDown("o"))
            {
                Instantiate(_effect, _effectPosition, transform.rotation);
                _gameManager.HP -= 1;
                Debug.Log("o");
            }
            if (Input.GetButtonDown("p"))
            {
                Instantiate(_effect, _effectPosition, transform.rotation);
                _gameManager.HP -= 1;
                Debug.Log("p");
            }
            if (Input.GetButtonDown("q"))
            {
                Instantiate(_effect, _effectPosition, transform.rotation);
                _gameManager.HP -= 1;
                Debug.Log("q");
            }
            if (Input.GetButtonDown("s"))
            {
                Instantiate(_effect, _effectPosition, transform.rotation);
                _gameManager.HP -= 1;
                Debug.Log("s");
            }
            if (Input.GetButtonDown("t"))
            {
                Instantiate(_effect, _effectPosition, transform.rotation);
                _gameManager.HP -= 1;
                Debug.Log("t");
            }
            if (Input.GetButtonDown("u"))
            {
                Instantiate(_effect, _effectPosition, transform.rotation);
                _gameManager.HP -= 1;
                Debug.Log("u");
            }
            if (Input.GetButtonDown("v"))
            {
                Instantiate(_effect, _effectPosition, transform.rotation);
                _gameManager.HP -= 1;
                Debug.Log("v");
            }
            if (Input.GetButtonDown("w"))
            {
                Instantiate(_effect, _effectPosition, transform.rotation);
                _gameManager.HP -= 1;
                Debug.Log("w");
            }
            if (Input.GetButtonDown("x"))
            {
                Instantiate(_effect, _effectPosition, transform.rotation);
                _gameManager.HP -= 1;
                Debug.Log("x");
            }
            if (Input.GetButtonDown("y"))
            {
                Instantiate(_effect, _effectPosition, transform.rotation);
                _gameManager.HP -= 1;
                Debug.Log("y");
            }
            if (Input.GetButtonDown("z"))
            {
                Instantiate(_effect, _effectPosition, transform.rotation);
                _gameManager.HP -= 1;
                Debug.Log("z");
            }
        }
    }
}
