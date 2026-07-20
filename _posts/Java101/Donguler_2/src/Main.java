import java.util.Scanner;

public class Main {
    static void main() {
        Scanner sc = new Scanner(System.in);
        int sonSayi, i = 1;

        System.out.print("Son Sayıyı Giriniz: ");
        sonSayi = sc.nextInt();

        while (i <= sonSayi) {
            System.out.println("4^"+ i +": " + (int)Math.pow(4,i) + "\n" + "5^"+ i +": " + (int)Math.pow(5,i));
            i++;
        }
    }
}
