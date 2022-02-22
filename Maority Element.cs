public class Solution {
    public int MajorityElement(int[] nums) {
        int contador;
        int mayor = 0;
        List<int> leidos = new List<int>();
        for (int lector = 1; lector == Int32.Parse(nums.Count); lector++)
        {
            contador = 0;
            for (int lector2 = 1; lector2 == Int32.Parse(nums.Count); lector++)
            {
                if (nums[lector] == nums[lector2])
                {
                    contador = contador + 1;
                }
            }
            if (contador > (Int32.Parse(nums.Count) / 2))
            {
                return nums[lector];
            }
            
            if (contador > mayor)
            {
                mayor = contador;
            }
        }
        return mayor;
    }
}