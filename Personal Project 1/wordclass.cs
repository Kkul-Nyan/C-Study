using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Project_1
{
    internal class wordclass
    {
        private int A;
        private string[] korwords = new string[]
        {             "안녕", "사과", "젓가락", "숫가락", "마우스", "모니터", "아침햇살", "힘들다", "가방", "고양이",
             "담배", "강아지", "벚꽃나무", "드레곤볼", "프로젝터", "냥냥이", "꿀떡이", "부산", "서울", "대구",
             "바나나", "대전", "청주", "고등어", "도다리", "광어", "다금바리", "전갱이", "아징", "겨울바다",
             "전주", "비빔밥", "약주", "막걸리", "내동생", "부모님", "가족", "애완동물", "친구", "부랄친국",
             "경국지색", "휴대폰", "스마트폰", "연락처", "주소록", "금연", "금주", "희노애락", "고향", "별",
             "은하수", "단비", "소나기", "장마", "태풍", "맑음", "전화번호", "카카오아이디", "뜸북새", "뻐꾸기",
             "태양", "별똥별", "거북이", "토끼", "당근", "브로콜리", "라면", "우동", "우정", "정물화",
             "화요일", "일본", "본드", "드라이버", "버스", "스키", "키스", "스물여덟", "승리", "이발소",
             "소아비만", "만득이", "이차함수", "수영장", "장대비", "비밀친구", "구렁이", "이모님", "임창정", "정복자",
             "자가용", "용가리", "이삿짐", "짐꾼", "이야기꾼", "물병", "점심시간", "배탈", "정글", "탑신병자" 
        };

        public wordclass(int a, string[] korword)
        {
            A1 = a;
            this.Korwords = korword;
        }

        public int A1 { get => A; set => A = value; }
        public string[] Korwords { get => korwords; set => korwords = value; }
        public void koreaword(int a)
        {
     
        }

    }
}

 






    
