using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using LitJson;

[CustomEditor(typeof(HttpTest))]
public class HttpTestEditor : Editor
{
    SerializedProperty m_Token;

    SerializedProperty m_Email;
    SerializedProperty m_RegisterEmailCode;
    SerializedProperty m_RegisterEmailUCode;
    SerializedProperty m_LoginEmailCode;

    SerializedProperty m_Pwd;
    SerializedProperty m_ucode;

    SerializedProperty m_ToAddress;
    SerializedProperty m_Value;

    SerializedProperty m_AirInfo;

    SerializedProperty m_Id;

    SerializedProperty m_Account;
    SerializedProperty m_Symbol;


    SerializedProperty m_PlatformProductInfo;
    SerializedProperty m_CityId;
    SerializedProperty m_Type;

    SerializedProperty m_PlatformOrderInfo;
    SerializedProperty m_OrderId;
    SerializedProperty m_PageNum;
    SerializedProperty m_PageSize;

    SerializedProperty m_FireworkInfo;
    SerializedProperty m_FireworkUid;
    SerializedProperty m_FireworkId;

    SerializedProperty m_VersionInfo;

    SerializedProperty m_Color;
    SerializedProperty m_NickName;
    SerializedProperty m_Sex;

    private void OnEnable()
    {
        m_Token = serializedObject.FindProperty("m_Token");

        m_Email = serializedObject.FindProperty("m_Email");
        m_RegisterEmailCode = serializedObject.FindProperty("m_RegisterEmailCode");
        m_RegisterEmailUCode = serializedObject.FindProperty("m_RegisterEmailUCode");
        m_LoginEmailCode = serializedObject.FindProperty("m_LoginEmailCode");

        m_Pwd = serializedObject.FindProperty("m_Pwd");
        m_ucode = serializedObject.FindProperty("m_ucode");

        m_ToAddress = serializedObject.FindProperty("m_ToAddress");
        m_Value = serializedObject.FindProperty("m_Value");

        m_AirInfo = serializedObject.FindProperty("m_AirInfo");

        m_Id = serializedObject.FindProperty("m_Id");

        m_Account = serializedObject.FindProperty("m_Account");
        m_Symbol = serializedObject.FindProperty("m_Symbol");

        m_PlatformProductInfo = serializedObject.FindProperty("m_PlatformProductInfo");
        m_CityId = serializedObject.FindProperty("m_CityId");
        m_Type = serializedObject.FindProperty("m_Type");

        m_PlatformOrderInfo = serializedObject.FindProperty("m_PlatformOrderInfo");
        m_OrderId = serializedObject.FindProperty("m_OrderId");
        m_PageNum = serializedObject.FindProperty("m_PageNum");
        m_PageSize = serializedObject.FindProperty("m_PageSize");

        m_FireworkInfo = serializedObject.FindProperty("m_FireworkInfo");
        m_FireworkUid = serializedObject.FindProperty("m_FireworkUid");
        m_FireworkId = serializedObject.FindProperty("m_FireworkId");

        m_VersionInfo = serializedObject.FindProperty("m_VersionInfo");

        m_Color = serializedObject.FindProperty("m_Color");
        m_NickName = serializedObject.FindProperty("m_NickName");
        m_Sex = serializedObject.FindProperty("m_Sex");
    }

    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();

        var target = (HttpTest)serializedObject.targetObject;

        EditorGUILayout.Space(5);

        EditorGUILayout.LabelField("------------------------------Token------------------------------");
        EditorGUILayout.PropertyField(m_Token);
        if (GUILayout.Button("SetToken"))
        {
            ServerConfigMgr.Private_Key = target.m_Token;
        }
        EditorGUILayout.TextField("Token : " + ServerConfigMgr.Token);
        EditorGUILayout.LabelField("------------------------------LoginModule------------------------------");
        EditorGUILayout.PropertyField(m_Email);
        if (GUILayout.Button("Register Email Code"))
        {
            target.RequestEmailCode();
        }
        EditorGUILayout.PropertyField(m_RegisterEmailCode);
        EditorGUILayout.PropertyField(m_RegisterEmailUCode);
        if (GUILayout.Button("Register Email Register"))
        {
            target.RequestEmailRegister();
        }
        EditorGUILayout.PropertyField(m_LoginEmailCode);
        if (GUILayout.Button("Request Email Login"))
        {
            target.RequestEmailLogin();
        }
        EditorGUILayout.PropertyField(m_Pwd);
        EditorGUILayout.PropertyField(m_ucode);
        if (GUILayout.Button("Request Forget Pwd"))
        {
            target.RequestForgetPwd();
        }
        EditorGUILayout.LabelField("CallBackData : ");
        EditorGUILayout.TextField("address : " + DynamicUserModel.Instance.userInfo.address);
        EditorGUILayout.TextField("area : " + DynamicUserModel.Instance.userInfo.area);
        EditorGUILayout.TextField("code : " + DynamicUserModel.Instance.userInfo.code);
        EditorGUILayout.TextField("color : " + DynamicUserModel.Instance.userInfo.color);
        EditorGUILayout.TextField("email : " + DynamicUserModel.Instance.userInfo.email);
        EditorGUILayout.TextField("fund : " + DynamicUserModel.Instance.userInfo.fund);
        EditorGUILayout.TextField("health : " + DynamicUserModel.Instance.userInfo.health);
        EditorGUILayout.TextField("id : " + DynamicUserModel.Instance.userInfo.id);
        EditorGUILayout.TextField("image : " + DynamicUserModel.Instance.userInfo.image);
        EditorGUILayout.TextField("life : " + DynamicUserModel.Instance.userInfo.life);
        EditorGUILayout.TextField("name : " + DynamicUserModel.Instance.userInfo.name);
        EditorGUILayout.TextField("nickName : " + DynamicUserModel.Instance.userInfo.nickName);
        EditorGUILayout.TextField("property : " + DynamicUserModel.Instance.userInfo.property);
        EditorGUILayout.TextField("sex : " + DynamicUserModel.Instance.userInfo.sex);
        EditorGUILayout.TextField("status : " + DynamicUserModel.Instance.userInfo.status);
        EditorGUILayout.TextField("tel : " + DynamicUserModel.Instance.userInfo.tel);
        EditorGUILayout.TextField("total : " + DynamicUserModel.Instance.userInfo.total);
        EditorGUILayout.TextField("ucode : " + DynamicUserModel.Instance.userInfo.ucode);

        EditorGUILayout.Space(5);
        EditorGUILayout.LabelField("------------------------------WalletModule------------------------------");
        EditorGUILayout.PropertyField(m_Account);
        EditorGUILayout.PropertyField(m_Symbol);
        if (GUILayout.Button("Request Balance Wallet"))
        {
            target.RequestBalanceWallet();
        }
        if (GUILayout.Button("Request Create Wallet"))
        {
            target.RequestCreateWallet();
        }
        if (GUILayout.Button("Request Get NFT List"))
        {
            target.RequestGetNFTList();
        }
        EditorGUILayout.LabelField("PrivateKey : " + ServerConfigMgr.Private_Key);
        if (GUILayout.Button("Request Private Key Recover Wallet"))
        {
            target.RequestPrivateKeyRecoverWallet();
        }
        EditorGUILayout.LabelField("Mnemonic : " + ServerConfigMgr.Mnemonic);
        if (GUILayout.Button("Request Mnemonic Recover Wallet"))
        {
            target.RequestMnemonicRecoverWallet();
        }
        EditorGUILayout.PropertyField(m_ToAddress);
        EditorGUILayout.PropertyField(m_Value);
        if (GUILayout.Button("Request Transfer Wallet"))
        {
            target.RequestTransferWallet();
        }
        EditorGUILayout.LabelField("CallBackData : ");
        EditorGUILayout.TextField("address : " + DynamicUserModel.Instance.walletInfo.address);
        EditorGUILayout.TextField("mnemonic : " + DynamicUserModel.Instance.walletInfo.mnemonic);
        EditorGUILayout.TextField("private_key : " + DynamicUserModel.Instance.walletInfo.private_key);


        EditorGUILayout.Space(5);
        EditorGUILayout.LabelField("------------------------------MyModule------------------------------");
        if (GUILayout.Button("Request Get User Info"))
        {
            target.RequestGetUserInfo();
        }
        EditorGUILayout.PropertyField(m_Color);
        EditorGUILayout.PropertyField(m_NickName);
        EditorGUILayout.PropertyField(m_Sex);
        if (GUILayout.Button("Request Set Role"))
        {
            target.RequestSetRole();
        }
        EditorGUILayout.Space(5);
        EditorGUILayout.LabelField("------------------------------AirModule------------------------------");
        foreach (var item in DynamicAirModel.Instance.idAirsDic)
        {
            EditorGUILayout.TextField(item.Key);
            EditorGUILayout.TextField(item.Value.createTime.ToString());
            EditorGUILayout.TextField(item.Value.from.ToString());
            EditorGUILayout.TextField(item.Value.id.ToString());
            EditorGUILayout.TextField(item.Value.num.ToString());
            EditorGUILayout.TextField(item.Value.price.ToString());
            EditorGUILayout.TextField(item.Value.status.ToString());
            EditorGUILayout.TextField(item.Value.to.ToString());
            EditorGUILayout.TextField(item.Value.updateTime.ToString());
        }
        EditorGUILayout.PropertyField(m_AirInfo);
        if (GUILayout.Button("Request Air Add"))
        {
            target.RequestAirAdd();
        }
        EditorGUILayout.PropertyField(m_Id);
        if (GUILayout.Button("Request Air Get One"))
        {
            target.RequestAirGetOne();
        }

        EditorGUILayout.Space(5);
        EditorGUILayout.LabelField("------------------------------PlatformModule------------------------------");
        EditorGUILayout.PropertyField(m_PlatformProductInfo);
        if (GUILayout.Button("Request Product Create"))
        {
            target.ProductCreate();
        }

        EditorGUILayout.PropertyField(m_PlatformOrderInfo);
        if (GUILayout.Button("Request Order Add"))
        {
            target.OrderAdd();
        }

        EditorGUILayout.Space(5);
        EditorGUILayout.LabelField("------------------------------FireworkModule------------------------------");
        EditorGUILayout.PropertyField(m_FireworkInfo);
        if (GUILayout.Button("Request Firework Create"))
        {
            target.RequestFireworkCreate();
        }
        EditorGUILayout.PropertyField(m_FireworkUid);
        if (GUILayout.Button("Request Firework List"))
        {
            target.RequestFireworkList();
        }
        EditorGUILayout.PropertyField(m_FireworkId);
        if (GUILayout.Button("Request Firework Update"))
        {
            target.RequestFireworkUpdate();
        }

        EditorGUILayout.Space(5);
        EditorGUILayout.LabelField("------------------------------VersionModule------------------------------");
        if (GUILayout.Button("Request Get Version"))
        {
            target.RequestGetVersion();
        }
        EditorGUILayout.PropertyField(m_VersionInfo);
        if (GUILayout.Button("Request Update Version"))
        {
            target.RequestUpdateVersion();
        }


        serializedObject.ApplyModifiedProperties();

        EditorUtility.SetDirty(target);
    }
}
