package pack;

import java.io.Serializable;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
/**
 *
 * @author Ahmad
 */
public class Grade {

    public double mark;
    public String symbol;

    public double getMark() {
        return mark;
    }

    public void setMark(double mark) {

        if (mark <= 100 && mark >= 95) {
            symbol = "A+";
        } else if (mark <= 94 && mark >= 85) {
            symbol = "A";
        } else if (mark <= 84 && mark >= 80) {
            symbol = "A-";
        } else if (mark <= 79 && mark >= 77) {
            symbol = "B+";
        } else if (mark <= 76 && mark >= 73) {
            symbol = "B";
        } else if (mark <= 72 && mark >= 70) {
            symbol = "B-";
        } else if (mark <= 69 && mark >= 67) {
            symbol = "C+";
        } else if (mark <= 66 && mark >= 63) {
            symbol = "C";
        } else if (mark <= 62 && mark >= 60) {
            symbol = "C-";
        } else if (mark <= 59 && mark >= 57) {
            symbol = "D+";
        } else if (mark <= 56 && mark >= 53) {
            symbol = "D";
        } else if (mark <= 52 && mark >= 50) {
            symbol = "D-";
        } else if (mark <= 49 && mark >= 0) {
            symbol = "F";
        } else {
            symbol = "error";
        }

        this.mark = mark;
    }

    public String getSymbol() {
        return symbol;
    }

    public void setSymbol(String symbol) {
        this.symbol = symbol;
    }

}
