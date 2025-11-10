import java.util.InputMismatchException;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        int matematik, fizik, kimya, turkce, tarih, muzik;
        Scanner scanner = new Scanner(System.in);

        matematik = gecerliNot(scanner, "Matematik");
        fizik = gecerliNot(scanner, "Fizik");
        kimya = gecerliNot(scanner, "Kimya");
        turkce = gecerliNot(scanner, "Türkçe");
        tarih = gecerliNot(scanner, "Tarih");
        muzik = gecerliNot(scanner, "Müzik");

        double ortalama = (matematik + fizik + kimya + turkce + tarih + muzik) / 6.0;

        System.out.printf("Not Ortalamanız: %.2f", ortalama);
        System.out.println(" ");
        if (ortalama < 50)
            System.out.println("Sonuç: Kaldınız");
        else
            System.out.println("Sonuç: Geçtiniz");
    }

    public static int gecerliNot(Scanner scanner, String dersAdi) {
        int not;
        while (true) {
            System.out.print(dersAdi + " Notunuzu Giriniz: ");
            try {
                not = scanner.nextInt();

                if (not >= 0 && not <= 100) {
                    break;
                } else {
                    System.out.println("Lütfen 0 ile 100 arasında bir değer giriniz!");
                }
            } catch (InputMismatchException e) {
                System.out.println("Geçersiz giriş! Lütfen sadece sayı giriniz.");
                scanner.next();
            }
        }
        return not;
    }
}
