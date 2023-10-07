#ifndef LOCOMOTION_H
#define LOCOMOTION_H

class Locomotion {
public:
    // Constructor
    Locomotion();

    // Destructor
    ~Locomotion();

    // Methods for different types of movement
    void run();
    void jump();
    void sit();
    void stationary();
    void layDown(bool faceUp);

    // Getter and setter methods for isRunning
    bool isRunning() const;
    void setRunning(bool newRunning);

    // Getter and setter methods for isJumping
    bool isJumping() const;
    void setJumping(bool newJumping);

    // Getter and setter methods for isSitting
    bool isSitting() const;
    void setSitting(bool newSitting);

    // Getter and setter methods for isStanding
    bool isStanding() const;
    void setStanding(bool newStanding);

    // Getter and setter methods for isLyingDown
    bool isLyingDown() const;
    void setLyingDown(bool newLyingDown);

private:
    // Private member variables
    bool running;
    bool jumping;
    bool sitting;
    bool standing;
    bool lyingDown;
};

class Action {
public:
    // Constructor
    Action();

    // Destructor
    ~Action();

    // Methods for various actions
    void lift();
    void squat();
    void stretch();
    void bend();
    void pushUp();
    void pullUp();
    void plank();
    void lunge();
    void box();
    void jumpRope();
    void legPress();

    // Getter and setter methods for actionIntensity
    int getActionIntensity() const;
    void setActionIntensity(int newIntensity);

    // Getter and setter methods for weightAmount
    double getWeightAmount() const;
    void setWeightAmount(double newWeight);

    // Getter and setter methods for repAmount
    int getRepAmount() const;
    void setRepAmount(int newReps);

private:
    // Private member variables
    int actionIntensity;
    double weightAmount;
    int repAmount;
};

class BodyChange {
public:
    // Constructor
    BodyChange();

    // Destructor
    ~BodyChange();

    // Methods for changing weight and muscle
    void weight(IncreaseDecrease change);
    void muscle(IncreaseDecrease change);

private:
    // Private member variables for tracking weight and muscle changes
    double weightChange;
    double muscleChange;
};

enum IncreaseDecrease {
    Increase,
    Decrease
};

class CompleteWorkout {
public:
    // Constructor
    CompleteWorkout();

    // Destructor
    ~CompleteWorkout();

    // Methods for updating daily, weekly, monthly, and yearly goals
    void updateDailyGoal();
    void updateWeeklyGoal();
    void updateMonthlyGoal();
    void updateYearlyGoal();

private:
    // Private member variables for tracking goals
    int dailyGoal;
    int weeklyGoal;
    int monthlyGoal;
    int yearlyGoal;
};

#endif