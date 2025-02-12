import requests 

url = "datatrust-as-gmc9dwd6bghtapby.swedencentral-01.azurewebsites.net"


antal_forfragningar = 100 

for i in range(antal_forfragningar):
    response = requests.get(url)
    print(f"Förfrågan {i+1}: Statuskod: {response.status_code}")
    