import java.util.Scanner;

public class Main {
    static void main() {
        Scanner sc = new Scanner(System.in);
        int sayi, toplam = 0;

        while (true) {
            System.out.print("Sayı girin: ");
            sayi = sc.nextInt();

            if (sayi % 2 == 0) {
                toplam += sayi;
            }
            else {
                System.out.println("Lütfen çift sayı giriniz!");
                break;
            }
        }
        System.out.println("Toplam: " + toplam);
    }
}
