package thread_os_c_a;

import java.util.ArrayList;

public class minimum  {

    private ArrayList<Double> list;
    private double Result;

    public double getResult() {
        return Result;
    }

    public minimum(ArrayList<Double> list) {
        this.list = list;
    }

    
    
    public  void run() {
        int a=0;
        double min = list.get(0);
        for (int i = 0; i < list.size(); i++) {
            if (list.get(i)<min) {
                min = list.get(i);
            }
        }

        Result = min;
//         while(a<200000)
//        {
//            a++;
//                  
//            System.out.println("count "+a);
//        
//        }
    }
}
