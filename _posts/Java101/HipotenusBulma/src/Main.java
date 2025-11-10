import java.util.InputMismatchException;
import java.util.Scanner;

class Main {
    static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        double birinciKenar, ikinciKenar;

        birinciKenar=gecerliKenar(scanner,"Birinci");
        ikinciKenar=gecerliKenar(scanner,"İkinci");

        double hipotenus = Math.sqrt(Math.pow(birinciKenar, 2) + Math.pow(ikinciKenar, 2));

        double u = (birinciKenar + ikinciKenar + hipotenus) / 2;

        double alan = Math.sqrt(u * (u - birinciKenar) * (u - ikinciKenar) * (u - hipotenus));

        System.out.printf("Hipotenüs: %s%n", (hipotenus % 1 == 0)
                ? String.format("%.0f", hipotenus)
                : String.format("%.2f", hipotenus)
        );
        System.out.printf("Üçgenin Alanı: %s%n", (alan % 1 == 0)
                ? String.format("%.0f", alan)
                : String.format("%.2f", alan));

    }

    public static double gecerliKenar(Scanner scanner, String kenarAdi){
        double kenar=-1;
        while (true){
            System.out.print(kenarAdi+" Kenarı Giriniz: ");
            try {
                kenar= scanner.nextDouble();
                if (kenar>0) break;
                else System.out.println("Kenar uzunluğu sıfır veya negatif olamaz!");
            }catch (InputMismatchException e){
                System.out.println("Geçersiz giriş! Lütfen sadece sayı giriniz.");
                scanner.next();
            }
        }
        return kenar;
    }
}