/*
 * ��ӹȺ����3D���ư�
 * https://github.com/jynew/jynew
 *
 * ���Ǳ���Դ��Ŀ�ļ�ͷ�����д����ʹ��MITЭ�顣
 * ����Ϸ����Դ�͵����������dll������ϸ�Ķ�LICENSE�����ȨЭ���ĵ���
 *
 * ��ӹ������ǧ�ţ�
 */
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public partial class BattleActionUIPanel
{
	private VerticalLayoutGroup LeftActions_VerticalLayoutGroup;
	private Button Move_Button;
	private Button UsePoison_Button;
	private Button Depoison_Button;
	private Button Heal_Button;
	private Button Item_Button;
	private Button Wait_Button;
	private Button Rest_Button;
	private RectTransform Skills_RectTransform;
	private Button Surrender_Button;
	private Button Cancel_Button;

	public void InitTrans()
	{
		LeftActions_VerticalLayoutGroup = transform.Find("LeftActions").GetComponent<VerticalLayoutGroup>();
		Move_Button = transform.Find("LeftActions/Move").GetComponent<Button>();
		UsePoison_Button = transform.Find("LeftActions/UsePoison").GetComponent<Button>();
		Depoison_Button = transform.Find("LeftActions/Depoison").GetComponent<Button>();
		Heal_Button = transform.Find("LeftActions/Heal").GetComponent<Button>();
		Item_Button = transform.Find("LeftActions/Item").GetComponent<Button>();
		Wait_Button = transform.Find("LeftActions/Wait").GetComponent<Button>();
		Rest_Button = transform.Find("LeftActions/Rest").GetComponent<Button>();
		Skills_RectTransform = transform.Find("Skills").GetComponent<RectTransform>();
		Surrender_Button = transform.Find("Surrender").GetComponent<Button>();
		Cancel_Button = transform.Find("Cancel").GetComponent<Button>();

	}
}
