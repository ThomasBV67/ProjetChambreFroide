class GPIO:
    value = 0
    def __init__(self):
        pass
    
    def setValue(self, newVal):
        self.value = newVal

    def getValue(self):
        return self.value
