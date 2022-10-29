using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using DG.Tweening;

public class GameManager : MonoBehaviour
{
    [SerializeField] int _maxHP;
    [SerializeField] Slider _hpSlider;
    [SerializeField] Text _hpText;
    [SerializeField] Text _timerText;
    [SerializeField] int _maxTime;
    [SerializeField] GameObject _main;
    [SerializeField] GameObject _gameOver;
    [SerializeField] GameObject _gameClear;
    [SerializeField] GameObject _effect;
    [SerializeField] Transform _muzzle;
    bool _effectPlay = true;
    int _hp;
    float _timer;
    bool _isGame = true;

    public int HP { get => _hp; set => _hp = value; }
    public bool IsGame { get => _isGame; }

    private void Start()
    {
        _hp = _maxHP;
        _hpSlider.maxValue = _hp;
    }
    void Update()
    {
        if (_isGame)
        {
            _timer += Time.deltaTime;
            _hpSlider.value = _hp;
            _hpText.text = $"{_hp}/{_maxHP}";
            _timerText.text = $"TIME:{(_maxTime - _timer).ToString("f2")}";
            if (_maxTime - _timer <= 0)
            {
                Debug.Log("GameOver");
                //_timer = 0;
                //_isGame = false;
                _main.SetActive(false);
                _gameOver.SetActive(true);
                _isGame = false;
                //GameOver
            }
            if (_hp <= 0)
            {
                _isGame = false;
                _main.SetActive(false);
                _gameClear.SetActive(true);
                //GameClear
            }
            if(_hp <= _maxHP / 3 && _effectPlay)
            {
                Debug.Log("�̏ᒆ");
                Instantiate(_effect, _muzzle.position, transform.rotation);
                _effectPlay = false;
            }
        }
    }
}
