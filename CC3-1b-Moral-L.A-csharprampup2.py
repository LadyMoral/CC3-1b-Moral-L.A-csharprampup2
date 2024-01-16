lbs = int(input("Enter weight in pounds: "))
kg_conv = 0.45359237
kg = lbs * kg_conv
print("Weight in Kilograms: " + str(kg) + " kg.")
print("------------------------------------------")

mi = int(input("Enter distance in miles: "))
km_conv = 1.60934
km = mi * km_conv
print("Distance in kilometers: " + str(km) + " km.")
print("------------------------------------------")

temp_far = input("Enter temperature in Fahrenheit: ")
temp_cel = ((float(temp_far) - int(32)) / 1.8)
print("Temperature in Celsius: " + str(temp_cel))
print("------------------------------------------")

age1 = int(input("Enter a number for student 1: "))
age2 = int(input("Enter a number for student 2: "))
age3 = int(input("Enter a number for student 3: "))
age4 = int(input("Enter a number for student 4: "))
age5 = int(input("Enter a number for student 5: "))
age6 = int(input("Enter a number for student 6: "))
age7 = int(input("Enter a number for student 7: "))
age8 = int(input("Enter a number for student 8: "))
age9 = int(input("Enter a number for student 9: "))
age10 = int(input("Enter a number for student 10: "))
age_avg = age1 + age2 + age3 + age4 + age5 + age6 + age7 + age8 + age9 + age10
print()
print("Student Age 1: " + str(age1))
print("Student Age 2: " + str(age2))
print("Student Age 3: " + str(age3))
print("Student Age 4: " + str(age4))
print("Student Age 5: " + str(age5))
print("Student Age 6: " + str(age6))
print("Student Age 7: " + str(age7))
print("Student Age 8: " + str(age8))
print("Student Age 9: " + str(age9))
print("Student Age 10: " + str(age10))
print("The average age of the 10 students is " + str(age_avg/10))
print("")

char1 = "Lady"
char2 = "Ananchelle"
char3 = "Mila"
char4 = "Mias"
char5 = "Mel"



print("In the small town of Hadassa, there lived 5 fearless warriors:")
print(f"{char1}, {char2}, {char3}, {char4}, and {char5} embarked on a quest to locate the Enchanted Crystal, "
      "a gem capable of restoring harmony and peace to their world.")
print("Along the way, they encountered talking mountains, fiery creatures, and deadly mirages.")
print("As they neared the crystal, they discovered its power to heal, igniting a spark of hope within them.")
print(f"At the journey's final step, just outside the Enchanted Crystal, there was an Ogre guarding the gem.")
print("Despite the ogre being the most dangerous creature in their world, their teamwork prevailed, and they slayed it.")
print(f"After obtaining the Enchanted Crystal, they returned home and resolved all the issues in their world.")
print("Finally, they all lived happily with peace and harmony in their world.")


number1 = int(input("Enter a number for experiment 1: "))
if number1 <= 0:
    print("Invalid input")
else:
    for i in range(1, number1 + 1):
        for j in range(1, i + 1):
            print(j, end=" ")
        print()
print("------------------------------------------")

number2 = int(input("Enter a number for experiment 2: "))
if number2 <= 0:
    print("Invalid input")
else:
    result = 0
    for i in range(1, number2 + 1):
        result += i
    print("The sum of numbers from 1 to " + str(number2) + " is " + str(result) + " .")
print("------------------------------------------")

number3 = int(input("Enter a number for experiment 3: "))
if number3 <= 0:
    print("Invalid input")
else:
    for i in range(number3, 0, -1):
        print(*range(1, i + 1))
print("------------------------------------------")
