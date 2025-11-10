import java.util.Scanner;

public class Main {
    static void main(String[] args) {
        Scanner scanner=new Scanner(System.in);

        System.out.print("Boyunuzu Giriniz: ");
        double boy= scanner.nextDouble();
        System.out.print("Kilonuzu Giriniz: ");
        double kilo= scanner.nextDouble();

        double vki=kilo/(boy*boy);
        System.out.printf("Vücut Kitle İndeksiniz: %.2f",vki);
    }
}
