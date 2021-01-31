package com.company;

public class Motor extends Car {
    public Motor(String name, int yaş) {
        super(name, yaş);
    }

    @Override
    public void benzinAl() {
        System.out.println("benzin alındı : motor");
    }

}
