using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
    [SerializeField] private Image _img;
    [SerializeField] private Sprite _default,_pressed;
    [SerializeField] private AudioClip _compressClip,_uncompressClip;
    [SerializeField] private AudioSource _source;

    public void OnPointerDown(PointerEventData eventData)
    {
        _img.sprite = _pressed;
        _source.PlayOneShot(_compressClip);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _img.sprite = _default;
        _source.PlayOneShot(_uncompressClip);
    }

    public void OpenTiktok()
    {
        Application.OpenURL("https://vt.tiktok.com/ZS8W9F2T2/");
    }

    public void OpenShopee()
    {
        Application.OpenURL("https://shope.ee/6zo5TkzDkG");
    }

    public void OpenAR()
    {
        SceneManager.LoadScene(1);
       
    }
}
