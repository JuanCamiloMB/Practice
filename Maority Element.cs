public class Solution {
    public int MajorityElement(int[] nums) {
        int contador;
        int mayor = 0;
        int mayor_n;
        List<int> leidos = new List<int>();
        for (int lector = 0; lector == nums.Length; lector++)
        {
            contador = 0;
            for (int lector2 = 0; lector2 == nums.Length; lector++)
            {
                if (nums[lector] == nums[lector2])
                {
                    contador = contador + 1;
                }
            }
            if (contador > (nums.Length) / 2)
            {
                return nums[lector];
            }
            
            if (contador >= mayor)
            {
                mayor = contador;
                mayor_n = nums[lector]; 
            }
        }
        return mayor_n;
    }
}
