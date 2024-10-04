
const inputBox = document.getElementById("KindergartenName");
const comboBox = document.getElementById("KindergartenNameSelect");

if (comboBox == null) {
    console.error("Not found!");
} else {
    // Funktsioon tekstikasti väärtuse muutmisel
    inputBox.addEventListener("input", () => {
        const inputValue = inputBox.value;
        for (let i = 0; i < comboBox.options.length; i++) {
            if (comboBox.options[i].value === inputValue) {
                comboBox.selectedIndex = i;
                break;
            }
        }
    });

    // Funktsioon rippmenüü väärtuse muutmisel
    comboBox.addEventListener("change", () => {
    inputBox.value = comboBox.value;
    });
}

const inputBoxT = document.getElementById("Teacher");
const comboBoxT = document.getElementById("TeacherNameSelect");

if (comboBoxT == null) {
    console.error("Not found!");
} else {
    // Funktsioon tekstikasti väärtuse muutmisel
    inputBoxT.addEventListener("input", () => {
        const inputValue = inputBoxT.value;
        for (let i = 0; i < comboBoxT.options.length; i++) {
            if (comboBoxT.options[i].value === inputValue) {
                comboBoxT.selectedIndex = i;
                break;
            }
        }
    });

    // Funktsioon rippmenüü väärtuse muutmisel
    comboBoxT.addEventListener("change", () => {
        inputBoxT.value = comboBoxT.value;
    });
}


const inputBoxG = document.getElementById("GroupName");
const comboBoxG = document.getElementById("GroupNameSelect");

if (comboBoxG == null) {
    console.error("Not found!");
} else {
    // Funktsioon tekstikasti väärtuse muutmisel
    inputBoxG.addEventListener("input", () => {
        const inputValue = inputBoxG.value;
        for (let i = 0; i < comboBoxG.options.length; i++) {
            if (comboBoxG.options[i].value === inputValue) {
                comboBoxG.selectedIndex = i;
                break;
            }
        }
    });

    // Funktsioon rippmenüü väärtuse muutmisel
    comboBoxG.addEventListener("change", () => {
        inputBoxG.value = comboBoxG.value;
    });
}