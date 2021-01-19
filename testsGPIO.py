from gpio import GPIO
from writeDB import WriteDB

gpio0 = GPIO()
gpio2 = GPIO()
gpio4 = GPIO()
gpio8 = GPIO()

potato = gpio2.getValue()

gpio2.setValue(4)

potatoToo = gpio2.getValue()

gpio8.setValue(5)

test = 0 