import React from "react";
import { FormControlLabel, Checkbox } from "@mui/material";
import { Controller } from "react-hook-form";

const ControlledCheckbox = ({ control, fieldName, rules, label, disabled }) => {
  return (
    <FormControlLabel
      control={
        <Controller
          name={fieldName}
          control={control}
          rules={rules}
          render={({ field: props }) => (
            <Checkbox
              {...props}
              disabled={disabled}
              checked={props.value}
              onChange={(e) => props.onChange(e.target.checked)}
            />
          )}
        />
      }
      label={label}
      disabled={disabled}
    />
  );
};

export default ControlledCheckbox;