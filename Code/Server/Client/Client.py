import socket
import RPi.GPIO as GPIO
from mfrc522 import SimpleMFRC522
reader = SimpleMFRC522()

while True:
    (id,text) = reader.read_no_block()
    if text is not None:
        s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        s.connect(("127.0.0.1", 8080))
        s.send(bytes(f"{id}".encode('ascii')))
        s.close()
        GPIO.cleanup()
        break
