from influxdb import InfluxDBClient # nécessaire pour Influx : pip install influxdb (à installer) 

class WriteDB:
    def __init__(self):
        pass
    def write(self,temp):
        json_body = [
            {
                "measurement": "testGraph",
                "fields": {
                    "Temperature" : float(temp)
                }
            }
        ]
        client = InfluxDBClient("127.0.0.1",8086,'projet','projet','testProjet')
        client.write_points(json_body)
        client.close()