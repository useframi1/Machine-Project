import numpy as np


def bin(label: np.ndarray):
    label_copy = label.copy()
    label_copy[label <= 30] = 0
    label_copy[label_copy > 30] = 1

    return label_copy
