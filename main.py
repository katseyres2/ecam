import re
import sys

# ----------------------------------------------------------------------- 1.

def RegEx_matchPhoneNumber(value:str):
    pattern = re.compile(r"\+\d{2} \d{3} \d{3} \d{3}")
    return pattern.match(value)

def RegEx_matchIntNumber(value:str):
    value = str(value)
    pattern = re.compile(r"-?\d+")
    return pattern.match(value)
    
def RegEx_matchLicensePlate(value:str):
    pattern = re.compile(r"[1-9]?[A-Z]{3}\d{3}|[1-9]?\d{3}[A-Z]{3}")
    return pattern.match(value.upper())

def RegEx_matchWindowsPath(value:str):
    pattern = re.compile(r"C:\\([\w-]+\\)*.+\.\w+")
    return pattern.fullmatch(value)

# ----------------------------------------------------------------------- 2.

def RegEx_findNumberInFile(path:str):
    pattern = re.compile(r"[\+-]?\d+")

    with open(path, mode='r') as f:
        data = f.readlines()
        for indexLine, line in enumerate(data):
            result = re.findall(pattern, line)
            if (result):
                print("Line {0}: {1}".format(indexLine, ", ".join(result)))

# ----------------------------------------------------------------------- 3.



# ----------------------------------------------------------------------- TEST

phoneNumber = "+32 472 102 008"
intNumber = "-0353"
licencePlate = "2324ede"
windowsPath = "C:\\Users\\Denis\\putty-64bit-0.74-installer.msi"

if __name__ == '__main__':
    # print(RegEx_matchPhoneNumber(phoneNumber))
    # print(RegEx_matchIntNumber(intNumber))
    # print(RegEx_matchLicensePlate(licencePlate))
    # print(RegEx_matchWindowsPath(windowsPath))

    try:
        RegEx_findNumberInFile(sys.argv[1])
    except:
        RegEx_findNumberInFile("findNumber.txt")
