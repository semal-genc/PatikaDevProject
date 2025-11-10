import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        double tutar, kdvOrani = 0;
        Scanner scanner = new Scanner(System.in);

        System.out.print("Ücret tutarını giriniz: ");
        tutar = scanner.nextDouble();

        if (tutar >= 0 && tutar <= 1000)
            kdvOrani = .18;
        else if (tutar > 1000)
            kdvOrani = .8;

        System.out.println("KDV Oranı: " + kdvOrani);

        //double kdv = tutar + tutar * 18 / 100;
        double kdvliTutar = tutar + tutar * kdvOrani;
        System.out.printf("KDV'li Tutar: %.2f", kdvliTutar);
    }
}
