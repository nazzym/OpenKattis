def main():
    data = []

    month_map = {
        "JAN": "January",
        "FEB": "February",
        "MAR": "March",
        "APR": "April",
        "MAY": "May",
        "JUN": "June",
        "JUL": "July",
        "AUG": "August",
        "SEP": "September",
        "OCT": "October",
        "NOV": "November",
        "DEC": "December"
    }

    def get_input_data():
        entry = input().strip()
        month, date = entry.split()
        month = month_map.get(month.upper(), month)  # Convert short month name to full name
        data.append((month, int(date)))

    get_input_data()

    if data:
        month, date = data[0]
        if (month == "October" and date == 31) or (month == "December" and date == 25):
            print("yup")
        else:
            print("nope")

if __name__ == "__main__":
    main()