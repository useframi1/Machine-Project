import numpy as np


def bin(label: np.ndarray):
    label_copy = label.copy()
    label_copy[label <= 30] = 0
    label_copy[(label_copy > 30) & (label_copy <= 60)] = 1
    label_copy[(label_copy > 60) & (label_copy <= 180)] = 2
    label_copy[(label_copy > 180) & (label_copy <= 300)] = 3
    label_copy[label_copy > 300] = 4

    return label_copy
