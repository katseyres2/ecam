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
    sentence = ""

    with open(path, mode='r') as f:
        data = f.readlines()
        for indexLine, line in enumerate(data):
            result = re.findall(pattern, line)
            if (result):
                sentence += "Line {0}: {1}\n".format(indexLine, ", ".join(result))
    
    return sentence

# ----------------------------------------------------------------------- 3.

def RegEx_cutURL(path:str):
    protocol = re.search(r"https?", path)
    domain = re.search(r"www\..+\.com", path)
    path = re.search(r"/[\w\-\/]*", path)

    return path




# ----------------------------------------------------------------------- TEST

phoneNumber = "+32 472 102 008"
intNumber = "-0353"
licencePlate = "2324ede"
windowsPath = "C:\\Users\\Denis\\putty-64bit-0.74-installer.msi"
url = "https://www.stackoverflow.com/questions/12453580/how-to-concatenate-items-in-a-list-to-a-single-string"

if __name__ == '__main__':
    # print(RegEx_matchPhoneNumber(phoneNumber))
    # print(RegEx_matchIntNumber(intNumber))
    # print(RegEx_matchLicensePlate(licencePlate))
    # print(RegEx_matchWindowsPath(windowsPath))

    # try:
    #     print(RegEx_findNumberInFile(sys.argv[1]))
    # except:
    #     print(RegEx_findNumberInFile("findNumber.txt"))

    print(RegEx_cutURL(url))
