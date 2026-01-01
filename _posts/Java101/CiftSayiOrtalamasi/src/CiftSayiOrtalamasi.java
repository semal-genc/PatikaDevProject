import java.util.Scanner;

public class CiftSayiOrtalamasi {
    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);

        int sayi;
        int toplam = 0;
        int adet = 0;

        System.out.print("Bir sayı giriniz: ");
        sayi = input.nextInt();

        for (int i = 0; i <= sayi; i++) {
            if (i % 3 == 0 && i % 4 == 0) {
                toplam += i;
                adet++;
            }
        }

        if (adet > 0) {
            double ortalama = (double) toplam / adet;
            System.out.println("Ortalama: " + ortalama);
        } else {
            System.out.println("3 ve 4'e tam bölünen sayı bulunamadı.");
        }
    }
}
