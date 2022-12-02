namespace Lab2Tech;

public partial class Form1 : Form
{
    // Box has 500 values of float type
    class Box {
        public double[] coins = new double[500];

        Box() {
            var random = new Random();
            for (int i = 0; i < 500; i++) {
                coins[i] = random.NextDouble() * 10 + 0.1;
            }
        }

        public List<(double, (double, double))> TaskB() {
            var result = new List<(double, (double, double))>();

            for (int i = 0; i < 500; i++) {
                for (int j = 0; j < 500; j++) {
                    for (int k = 0; k < 500; k++) {
                        if (coins[i] == coins[j] + coins[k]) {
                            result.Add((coins[i], (coins[j], coins[k])));
                        }
                    }
                }
            }

            return result;
        }
    }
    private static int TaskA(ICollection<int> inputs) {
        var length = inputs.Count;
        var sum = 0;

        for (var i = 0; i < length; i++) {
            var will_be_if_plus = sum + inputs.ElementAt(i);
            var will_be_if_minus = sum - inputs.ElementAt(i);
            if (Math.Abs(will_be_if_plus) > Math.Abs(will_be_if_minus)) {
                sum = will_be_if_minus;
            } else {
                sum = will_be_if_plus;
            }
        }

        return sum;
    }
    public Form1()
    {
        InitializeComponent();
    }
}
enum Sign {
    Plus,
    Minus
}

class Optimized {

    public static Sign[] TaskA(int[] input) {
        return null;
    }

    public static Sign[] GenericTaskA<T>() where T: IComparable<T>,  {
        return null;
    }
}
