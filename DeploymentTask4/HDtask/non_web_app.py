import sys

def celsius_to_fahrenheit(celsius):
    return (celsius * 9/5) + 32

def fahrenheit_to_celsius(fahrenheit):
    return (fahrenheit - 32) * 5/9

def get_temperature_input():
    while True:
        try:
            temperature = float(input("Enter temperature: "))
            scale = input("Enter scale (C/F): ").upper()
            
            if scale == "C":
                converted = celsius_to_fahrenheit(temperature)
                print(f"{temperature}°C is {converted}°F")
            elif scale == "F":
                converted = fahrenheit_to_celsius(temperature)
                print(f"{temperature}°F is {converted}°C")
            else:
                print("Invalid scale. Use 'C' for Celsius or 'F' for Fahrenheit.")
                continue

            if input("Convert another temperature? (yes/no): ").lower() != "yes":
                break
        except ValueError:
            print("Please enter a valid number for temperature.")

if __name__ == "__main__":
    get_temperature_input()