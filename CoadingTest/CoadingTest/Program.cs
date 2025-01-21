namespace CoadingTest
{
    #region 1 코딩 기초 트레이닝 - 원하는 문자열 찾기(2025.01.20)

    public class Solution
    {
        public int solution(string myString, string pat)
        {
            myString = myString.ToLower();
            pat = pat.ToLower();


            if (myString.Contains(pat))
            {
                return 1;
            }

            else
            {
                return 0;
            }
        }
    }
    #endregion

    #region 2 코딩 테스트 연습 - 연습문제 - 크기가 작은 부분 문자열(2025.01.20)
    public class Solution2
    {
        public int solution2(string t, string p)
        {
            int answer = 0;
            int pLength = p.Length;
            long pInt = long.Parse(p);

            int tLength = t.Length;

            for (int i = 0; i <= tLength - pLength; i++)
            {
                //i번째부터 pLength까지 잘라서 sub string에 저장.
                string sub = t.Substring(i, pLength);
                //문자열인 sub을 long로 형변환해서 tint에 저장
                long tInt = long.Parse(sub);
                if (tInt <= pInt)
                {
                    answer++;
                }
            }
            return answer;
        }
    }
    #endregion

    #region 3 코딩 테스트 연습 - 연습문제 - 문자열 나누기(2025.01.21)
    public class Solution3
    {
        public int solution3(string s)
        {
            int answer = 1;
            char sWord = ' ';
            int sameX = 0;
            int elseX = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (i == 0)
                {
                    sWord = s[0];
                }
                if (sameX == elseX && sameX != 0)
                {
                    sameX = 0;
                    elseX = 0;
                    answer++;
                    sWord = s[i];
                }
                if (s[i] == sWord)
                {
                    sameX++;
                }
                if (s[i] != sWord)
                {
                    elseX++;
                }
            }
            return answer;
        }
    }
    #endregion(2025.01.
}
