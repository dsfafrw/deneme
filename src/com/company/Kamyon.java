package com.company;

public class Kamyon extends Car {
    public Kamyon(String name, int yaş) {
        super(name, yaş);
    }

    @Override
    public void benzinAl(){
        System.out.println("benzin alındı : kamyon");
    }
}
