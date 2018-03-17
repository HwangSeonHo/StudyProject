/*
	- 스탯 : 힘, 민첩, 맷집, 매력, 지능, 솜씨, 의지, 눈치 / 칭호(기본 스탯 업)
	- 기본 능력 : 최대 건강, 최대 에너지, 은신 능력
	- 채집 능력 : 식물 채집 능력, 채광 능력, 도축 능력, 분해 능력
	- 가공 능력 : 공예 능력, 재봉 능력, 금속 가공 능력
	- 전투 능력 : 공격력, 방어 관통, 정확도, 치명타, 방어력, 회피
	- 제작 능력 : 무기 제작 능력, 옷 제작 능력, 요리 능력, 농사 능력, 가구 제작 능력, 건설 능력
	- 생존 능력 : 더위 저항, 추위 저항, 습기 저항, 땡볕 저항, 강풍 저항
*/

public class Info_Player {


	//필요할때만 호출
	private int level;			//레벨
	private float str;			//힘
	private float agi;			//민첩
	private float health;		//맷집
	private float charm;		//매력
	private float inteligence;	//지능
	private float dex;			//솜씨
	private float will;			//의지
	private float sense;		//눈치

	private Player_Title title;				//칭호 배열?
	private Player_Inventory inventory;		//가방

	private float getStandardAbility(){
		return 0;
	}



}
