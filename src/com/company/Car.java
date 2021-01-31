package com.company;

public abstract class Car {
    private String name ;
    public int yaş;
    public abstract void benzinAl();
    public Car(String name , int yaş ){
        this.name=name ;
        this.yaş=yaş;
    }
}
