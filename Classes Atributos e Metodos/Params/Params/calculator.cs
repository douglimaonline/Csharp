namespace Params {
    public class Calculator {
        public static double Sum(params double[] list) {
            double total = 0;
            for (int i = 0; i < list.Length; i++) {
                total += list[i];
            }
            return total;
        }
    }
}
