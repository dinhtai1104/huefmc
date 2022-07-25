using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System;

public class LoginController : MonoBehaviour
{
    public Button loginBtn;
    public TMP_InputField usernameField;
    public TMP_InputField passwordField;
    public FragmentMessage messageUi;

    private void Start()
    {
        loginBtn.onClick.AddListener(LoginOnClicked);
    }

    private void LoginOnClicked()
    {
        loginBtn.interactable = false;
        string userName = usernameField.text;
        string passWord = passwordField.text;
        if (userName == string.Empty || passWord == string.Empty)
        {
            loginBtn.interactable = true;
            messageUi.OnShow("Lỗi", "Không được để trống tài khoản hoặc mật khẩu!");
        } else
        {
            LogController.Instance.Log(new LogData
            {
                ngay = DateTime.Now.ToLongTimeString(),
                hanhDong = "Đăng nhập thành công: " + userName,
                thoiGianThucHien = "---"
            });
            messageUi.OnShow("Thông báo", "Đăng nhập thành công!", ()=>
            {
                SceneManager.LoadSceneAsync(1);
            });
        }
    }
}
