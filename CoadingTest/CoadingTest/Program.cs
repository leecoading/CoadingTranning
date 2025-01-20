namespace CoadingTest
{
    #region 코딩 기초 트레이닝 - 원하는 문자열 찾기(2025.01.20)
    using System;

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

    #region 코딩 테스트 연습 - 연습문제 - 크기가 작은 부분 문자열(2025.01.20)
    #endregion
}
