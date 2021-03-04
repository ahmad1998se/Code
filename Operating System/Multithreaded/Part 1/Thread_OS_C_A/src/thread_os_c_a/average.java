package thread_os_c_a;

import java.util.ArrayList;

public class average  {

    private ArrayList<Double> list;
    private double Result;

    public double getResult() {
        return Result;
    }

    public average(ArrayList<Double> list) {
        this.list = list;
    }

    
    public  void run() {
        int a=0;
        double sum = 0;
        for (int i = 0; i < list.size(); i++) {
            sum += list.get(i);
        }

        Result = sum / list.size();
//         while(a<200000)
//        {
//            a++;
//                  
//            System.out.println("count "+a);
//        
//        }
    }
}
