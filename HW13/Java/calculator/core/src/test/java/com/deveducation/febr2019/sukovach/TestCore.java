package com.deveducation.febr2019.sukovach;
import junit.framework.Assert;
import org.junit.After;
import org.junit.Before;
import org.junit.Test;

public class TestCore {

    private Core core;

    @Before
    public void run(){
        core = new Core();
    }
    @After
    public void stop(){
        core = null;
    }

    @Test
    public void testAddition(){
        double testResult = core.addition(2,2);
        Assert.assertTrue(testResult == 4);
    }
    @Test
    public void testSubtraction(){
        double testResult = core.subtraction(2,2);
        if(testResult != 0.0) { Assert.fail();}
    }
    @Test
    public void testMultiplication(){
        double testResult = core.multiplication(2,2);
        if(testResult != 4) { Assert.fail();}
    }
    @Test
    public void testDivision(){
        double testResult = core.division(2,2);
        if(testResult != 1) { Assert.fail();}
    }
}
