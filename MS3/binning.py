import numpy as np


def bin(label: np.ndarray):
    label_copy = label.copy()
    label_copy[label <= 15] = 0
    label_copy[(label_copy > 15) & (label_copy <= 45)] = 1
    label_copy[(label_copy > 45) & (label_copy <= 120)] = 2
    label_copy[label_copy > 120] = 3

    return label_copy
