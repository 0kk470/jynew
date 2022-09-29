/*
 * ��ӹȺ����3D���ư�
 * https://github.com/jynew/jynew
 *
 * ���Ǳ���Դ��Ŀ�ļ�ͷ�����д����ʹ��MITЭ�顣
 * ����Ϸ����Դ�͵����������dll������ϸ�Ķ�LICENSE�����ȨЭ���ĵ���
 *
 * ��ӹ������ǧ�ţ�
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public partial class BattleMainUIPanel
{
	private RectTransform BattleHpRoot_RectTransform;
	private RectTransform CurrentRole_RectTransform;
	private Text NameText_Text;
	private Text DetailText_Text;
	private Image PreImage_Image;
	private Toggle AutoBattle_Toggle;
	private Button GiveUp_Button;
	private RectTransform HUDItem_RectTransform;

	public void InitTrans()
	{
		BattleHpRoot_RectTransform = transform.Find("BattleHpRoot").GetComponent<RectTransform>();
		CurrentRole_RectTransform = transform.Find("CurrentRole").GetComponent<RectTransform>();
		NameText_Text = transform.Find("CurrentRole/NameText").GetComponent<Text>();
		DetailText_Text = transform.Find("CurrentRole/DetailText").GetComponent<Text>();
		PreImage_Image = transform.Find("CurrentRole/HeadAvataPre/Mask/PreImage").GetComponent<Image>();
		AutoBattle_Toggle = transform.Find("AutoBattle").GetComponent<Toggle>();
		GiveUp_Button = transform.Find("GiveUp").GetComponent<Button>();
		HUDItem_RectTransform = transform.Find("Prefabs/HUDItem").GetComponent<RectTransform>();

	}
}
